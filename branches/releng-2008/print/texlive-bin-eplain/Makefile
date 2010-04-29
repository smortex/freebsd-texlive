# New ports collection makefile for:	texlive-bin-eplain
# Date created:		26/01/2009 16:04:56
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-eplain
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Extended plain tex macros.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.pdftex.cnf:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
