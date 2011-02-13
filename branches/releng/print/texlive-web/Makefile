# New ports collection makefile for:	texlive-web
# Date created:		13/03/2010 04:24:47
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	web
PORTVERSION=	20110213
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	original web programs tangle and weave

RUN_DEPENDS=	${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
