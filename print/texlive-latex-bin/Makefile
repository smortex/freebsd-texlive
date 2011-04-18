# New ports collection makefile for:	texlive-latex-bin
# Date created:		13/03/2010 04:20:36
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	latex-bin
PORTVERSION=	20110418
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	LaTeX executables and man pages.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
