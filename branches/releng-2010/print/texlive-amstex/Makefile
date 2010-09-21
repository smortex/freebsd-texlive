# New ports collection makefile for:	texlive-amstex
# Date created:		13/03/2010 04:54:19
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	amstex
PORTVERSION=	20100921
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	American Mathematical Society plain TeX macros.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
