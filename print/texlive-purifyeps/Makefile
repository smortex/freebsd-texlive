# New ports collection makefile for:	texlive-purifyeps
# Date created:		13/03/2010 04:24:22
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	purifyeps
PORTVERSION=	20101204
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Make EPS work with both LaTeX/dvips and pdfLaTeX.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
