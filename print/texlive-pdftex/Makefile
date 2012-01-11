# New ports collection makefile for:	texlive-pdftex
# Date created:		13/03/2010 04:19:52
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	pdftex
PORTVERSION=	20120111
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A TeX extension for direct creation of PDF.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
