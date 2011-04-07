# New ports collection makefile for:	texlive-metapost
# Date created:		13/03/2010 04:22:12
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	metapost
PORTVERSION=	20110407
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A development of MetaFont for creating graphics.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
