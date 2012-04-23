# New ports collection makefile for:	texlive-aleph
# Date created:		13/03/2010 04:55:34
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	aleph
PORTVERSION=	20120423
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Extended TeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf-dist/tex/lambda/base/lambda.tex:${PORTSDIR}/print/texlive-lambda \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
