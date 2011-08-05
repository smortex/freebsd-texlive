# New ports collection makefile for:	texlive-cslatex
# Date created:		13/03/2010 04:35:14
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	cslatex
PORTVERSION=	20110805
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	LaTeX support for Czech/Slovak typesetting.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
