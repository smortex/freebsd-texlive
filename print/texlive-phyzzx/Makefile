# New ports collection makefile for:	texlive-phyzzx
# Date created:		13/03/2010 04:30:51
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	phyzzx
PORTVERSION=	20100922
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A TeX format for physicists.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
